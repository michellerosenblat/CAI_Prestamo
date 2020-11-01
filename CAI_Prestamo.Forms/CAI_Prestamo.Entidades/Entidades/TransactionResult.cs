using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Prestamo.Entidades.Entidades
{
    public class TransactionResult
    {
        private bool isOk;
        private string error;
        private int id;

        public bool IsOk
        {
            get
            {
                return this.isOk;
            }
            set
            {
                this.isOk = value;
            }
        }

        public string Error
        {
            get
            {
                return this.error;
            }
            set
            {
                this.error = value;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
    }
}
