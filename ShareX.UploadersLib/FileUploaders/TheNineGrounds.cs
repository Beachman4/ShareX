#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2016 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.UploadersLib.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using System;

namespace ShareX.UploadersLib.FileUploaders
{

    public class TheNineGroundsUploaderService : FileUploaderService
    {
        public override FileDestination EnumValue { get; } = FileDestination.TheNineGrounds;

        public override Icon ServiceIcon => Resources.puush;

        public override bool CheckConfig(UploadersConfig config)
        {
            return !string.IsNullOrEmpty(config.T9GApiKey);
        }

        public override GenericUploader CreateUploader(UploadersConfig config, TaskReferenceHelper taskInfo)
        {
            return new TheNineGrounds(config.T9GApiKey);
        }

        public override TabPage GetUploadersConfigTabPage(UploadersConfigForm form) => form.tpT9G;
    }

	class TheNineGrounds : FileUploader
	{
		public const string TheNineGroundsURL = "http://localhost";
		public const string TheNineGroundsUploadURL = TheNineGroundsURL + "/api/upload";
		public const string TheNineGroundsLoginURL = TheNineGroundsURL + "/api/login";

        public const string TheNineGroundsRegisterURL = TheNineGroundsURL + "/register";

		public string ApiKey { get; set; }

		public TheNineGrounds()
		{

		}

		public TheNineGrounds(string Apikey)
		{
			ApiKey = Apikey;
		}

		public string Login(string email, string password)
		{
			Dictionary<string, string> arguments = new Dictionary<string, string>();
			arguments.Add("email", email);
			arguments.Add("password", password);

			string response = SendRequestMultiPart(TheNineGroundsLoginURL, arguments);

			if (!string.IsNullOrEmpty(response))
			{
                System.Console.WriteLine(response);
				return response;
			}

			return null;


		}

		public override UploadResult Upload(Stream stream, string fileName)
		{
			NameValueCollection headers = new NameValueCollection();
            headers.Add("apiKey", ApiKey);
            System.Console.WriteLine(TheNineGroundsUploadURL);
            UploadResult result = SendRequestFile(TheNineGroundsUploadURL, stream, fileName, "file", null, headers);

            System.Console.WriteLine(result.Response);

            if (result.IsSuccess)
            {
                string[] values = result.Response.Split(',');

                if (values != null && values.Length > 1)
                {
                    int status;

                    if (!int.TryParse(values[0], out status))
                    {
                        status = -2;
                    }

                    if (status < 0)
                    {
                        switch (status)
                        {
                            case -1:
                                Errors.Add("Authentication failure.");
                                break;
                        }
                    } else
                    {
                        result.URL = values[1];
                    }
                }
            }

            return result;
		}

	}
}
	