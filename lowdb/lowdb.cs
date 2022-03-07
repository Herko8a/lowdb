using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace lowdb
{
    public class lowdb<T>
    {
        public T data { get; set; }
        FileSync adapter;

        public lowdb(FileSync fs)
        {
            adapter = fs;
            this.read();
        }

        T read()
        {
            string sdata = adapter.read();
            data = JsonSerializer.Deserialize<T>(sdata);
            return data;
        }

        public bool write()
        {
            return adapter.write(JsonSerializer.Serialize(data));
        }

        public void refresh()
        {
            this.read();
        }

    }

}
