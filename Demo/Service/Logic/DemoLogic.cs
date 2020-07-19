using Demo.Shared.Models;
using Service.Data.SCHEMA_NAME;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Service.Logic
{
    public class DemoLogic
    {
        public DemoSetup GetAllData()
        {
            var demoSetup = new DemoSetup();
            var environment = "env";
            var sw = Stopwatch.StartNew();

            Time("LoadFunc1",()=> LoadFunc1(demoSetup));
            Time("LoadFunc2", () => LoadFunc2(demoSetup));
            Time("LoadFunc3", () => LoadFunc3(demoSetup));
            Time("LoadFunc4", () => LoadFunc4(demoSetup));

            sw.Stop();
            Debug.WriteLine($"TOTAL (ms)\t {sw.ElapsedMilliseconds}");
            return demoSetup;
        }

        private string GetSerialize<T>(T value)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            using (var sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xsSubmit.Serialize(writer,value);
                    return sw.ToString();
                }
            }
        }

        private string GetSerializeJson<T>(T value)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream();
            jsonSerializer.WriteObject(ms,value);
            byte[] json = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(json,0,json.Length);
        }
        private void LoadFunc4(DemoSetup demoSetup)
        {
            PKG_NAME.Load();
            //map the result
        }

        private void LoadFunc3(DemoSetup demoSetup)
        {
            PKG_NAME.Load();
            //map the result
        }

        private void LoadFunc2(DemoSetup demoSetup)
        {
            PKG_NAME.Load();
            //map the result
        }

        private void LoadFunc1(DemoSetup demoSetup)
        {
            
            PKG_NAME.Load();
            //map the result
        }

        private void Time(string msg, Action a)
        {
            try
            {
                var sw = Stopwatch.StartNew();
                a();
                sw.Stop();
                Debug.WriteLine($"{msg}(ms)\t {sw.ElapsedMilliseconds}");
            }
            catch (Exception ex)
            {

                var ERROR = msg + ":" + ex.ToString();
            }
        }

    }
}
