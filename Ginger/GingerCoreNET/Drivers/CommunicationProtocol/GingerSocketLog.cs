#region License
/*
Copyright © 2014-2018 European Support Limited

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at 

http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/
#endregion

using System;

namespace GingerCoreNET.Drivers.CommunicationProtocol
{
    public class NewGingerSocketLog
    {
        public DateTime TimeStamp {get; set;}
        public string LogType {get; set;}
        public string Name { get; set; }
        public string Info {get; set;}
        public int Len { get; set; }
        public long Elapsed { get; set; }
        public NewPayLoad PayLoad { get; set; }

        public NewGingerSocketLog()
        {
            TimeStamp = DateTime.Now;
        }

        internal void SetPayLoad(CommunicationProtocol.NewPayLoad pl)
        {            
            Name = pl.Name;
            Info = pl.ToString();
            Len = pl.PackageLen();
            PayLoad = pl;
        }
    }
}
