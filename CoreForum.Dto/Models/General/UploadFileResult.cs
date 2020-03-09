using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    public partial class UploadFileResult
    {
        public bool UploadSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string UploadedFileName { get; set; }
        public string UploadedFileUrl { get; set; }
    }
}
