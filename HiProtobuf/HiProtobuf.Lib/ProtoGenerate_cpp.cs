﻿using System;
using System.Collections.Generic;
using System.IO;

namespace HiProtobuf.Lib
{
    class ProtoGenerate_cpp:ProtoGenerateBase
    {
        private string _folder = "/cpp";
        public ProtoGenerate_cpp(string name, List<VariableInfo> infos) : base(name, infos)
        {
            Path += _folder;
            if (Directory.Exists(Path))
            {
                Directory.Delete(Path, true);
            }
            Directory.CreateDirectory(Path);
            Path = Path + "/" + name + ".proto";

            var header = @"
// This is auto generated by HiProtobuf
// Support: hiramtan@live.com

// [START declaration]
syntax = ""proto3"";
package HiProtobuf;

import ""google/protobuf/timestamp.proto"";
// [END declaration]
";
            header += "message " + name + " {";
            var sw = File.AppendText(Path);
            sw.WriteLine(header);
            sw.Close();
        }
    }
}
