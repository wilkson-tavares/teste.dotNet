using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TheosWebApplication.APP.ViewModel
{
    [DataContract]
    public class LivroViewModel
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "nome")]
        public string Nome { get; set; }
        [DataMember(Name = "autor_id")]
        public int AutorId { get; set; }
        [DataMember(Name = "genero_id")]
        public int GeneroId { get; set; }
    }
}
