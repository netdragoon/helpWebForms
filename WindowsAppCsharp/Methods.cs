using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Linq;
using System.Collections;

namespace WindowsAppCsharp
{
    public class AttachmentAndFileInfo
    {
        public Attachment Attachment { get; private set; }
        public FileInfo FileInfo { get; private set; }

        public AttachmentAndFileInfo(string fileName)
        {
            if (!File.Exists(fileName))
                throw new Exception("Inválid path");

            Attachment = new Attachment(fileName);
            FileInfo = new FileInfo(fileName);                
        }
    }

    public class AttachmentAndFileInfoList: List<AttachmentAndFileInfo>
    {
        public IList ToSelectList()
        {
            return this.Select(c => new
            {
                c.Attachment.Name,                
                Path = c.FileInfo.FullName,
                Length = c.FileInfo.Length,
                LengthDescription = fileInfoTam(c.FileInfo.Length)
            })
            .ToList();
        }

        public IList<Attachment> AttachmentToList()
        {
            return this.Select(c => c.Attachment).ToList();
        }

        public IList<FileInfo> FileInfoToList()
        {
            return this.Select(c => c.FileInfo).ToList();
        }

        internal string fileInfoTam(long length)
        {
            double value = (length / 1024);
            string label = "Kb";
            if ((length / 1024) > 1024)
            {
                value = ((length / 1024) / 1024);
                label = "Mb";
            }
            
            return string.Format("{0} {1}", Math.Round(value, 4), label);
        }
    }
}