#pragma checksum "C:\Repositories\Cambio-Climatico\Components\LoginBlazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9535ca8b49e8e3f29cf988d7f6b93e1abd888e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Cambio_Climático.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Repositories\Cambio-Climatico\Components\LoginBlazor.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repositories\Cambio-Climatico\Components\LoginBlazor.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repositories\Cambio-Climatico\Components\LoginBlazor.razor"
using Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repositories\Cambio-Climatico\Components\LoginBlazor.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class LoginBlazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Repositories\Cambio-Climatico\Components\LoginBlazor.razor"
       
    string loginEmail;
    string loginPassword;
    string mns_secreto1;
    void loginFunction()
    {
        int opt = UserController.login(loginEmail,loginPassword);
        if (opt == -1)
        {
            mns_secreto1 = "El correo introducido es inexistente";
        }
        else if(opt == 1) {
            mns_secreto1 = "Bienvenido Administrador";
            GlobalAtributtes.adminBoolean = true;
        }
        else if (opt == 2)
        {
            mns_secreto1 = "Bienvenido Investigador";
            GlobalAtributtes.InvestigatorBoolean = true;
        }
        else
        {
            mns_secreto1 = "Contraseña incorrecta";
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
