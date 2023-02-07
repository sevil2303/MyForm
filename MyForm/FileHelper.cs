using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForm
{
    public partial class Form1
    {
        private void Write(Person newperson)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{firstname}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, newperson);
                }
            }
        }
        private Person Read(Person person)
        {
            try
            {
                var context = File.ReadAllText($"{person.Firstname}.json");
                person = JsonConvert.DeserializeObject<Person>(context);
            }
            catch (Exception)
            {

            }
            return person;
        }
    }
}
