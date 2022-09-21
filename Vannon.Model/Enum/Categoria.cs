using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vannon.Model.Enum
{
    public enum Categoria
    {
        [Description("Infantil")]
        infantil=0,
        [Description("Comédia")]
        comedia =1,
        [Description("Terror")]
        terror =2,
        [Description("Ação")]
        acao =3,
        [Description("Suspense")]
        suspense =4,
        [Description("Drama")]
        drama =5
    }
}
