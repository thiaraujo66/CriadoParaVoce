//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CriadoParaVoceWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbTipoContato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoContato()
        {
            this.tbContatoCliente = new HashSet<tbContatoCliente>();
            this.tbContatoFuncionario = new HashSet<tbContatoFuncionario>();
        }
    
        public int CodigoTipoContato { get; set; }
        public string NomeTipoContato { get; set; }
        public Nullable<bool> StatusTipoContato { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbContatoCliente> tbContatoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbContatoFuncionario> tbContatoFuncionario { get; set; }
    }
}