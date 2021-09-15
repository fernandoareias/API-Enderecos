


using System;

namespace Api.Domain.Models
{
    public class MunicipioModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _cooIBGE;
        public int CodIBGE
        {
            get { return _cooIBGE; }
            set { _cooIBGE = value; }
        }

        private Guid _UfId;
        public Guid UfId
        {
            get { return _UfId; }
            set { _UfId = value; }
        }


    }
}