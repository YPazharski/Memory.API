using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory.API
{
    public class APIObject : IDisposable
    {
        int Id { get; }
        bool IsDisposed { get; set; }
        public APIObject(int id) 
        {
            Id = id;
            MagicAPI.Allocate(Id);
        }

        ~APIObject() 
        {
            Dispose();
        }

        public void Dispose()
        {
            if (!IsDisposed)
            {
                MagicAPI.Free(Id);
                IsDisposed = true;
            }
        }
    }
}
