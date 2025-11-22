///anticipar el siguiente select si es asociable

document.addEventListener("DOMContentLoaded", function () {
            const areaSelect = document.querySelector('select[name="Input.Area"]');
            const empresaSelect = document.querySelector('select[name="Input.Empresa"]');
            areaSelect.addEventListener("change", function () {
                const area = this.value;

                // Limpia la selección actual de empresa
                empresaSelect.value = "";

                // Asocia areas con sus emprsas 
                const mapa = {
                    "Petroliferos": "Pemex",
                    "Electricidad" :"CFE",
                    "Gas Licuado": "Privada 1",
                    "Gas Natural" : "Privada 2",
                    "Hidrocarburos":"Privada 3",
                };
                // Si existe relación selecciona la empresa k corresponde
                if (mapa[area]) {
                    empresaSelect.value = mapa[area];
                }
            });
        });

/////ISO-NOM-NMX
document.addEventListener("DOMContentLoaded",function(){
    const isoSelect = document.querySelector('select[name="Input.ISO"]');
    const nomSelect = document.querySelector('select[name="Input.NOM"]')
    const nmxSelect = document.querySelector('select[name="Input.NMX"]')

  const data = {
        "ISO-90001":{
            nom:"NOM-2390-013",
            nmx:"NMX-2983-992"
        },
        "ISO-90002":{
            nom:"NOM-3452-093",
            nmx:"NMX-2890-666"
        },
        "ISO-90003":{
            nom:"NOM-3466-666",
            nmx:"NMX-2223-890"
        },
        "ISO-90004":{
            nom:"NOM-8903-123",
            nmx:"NMX-2390-399"
        },
        "ISO-90005":{
            nom:"NOM-7890-234",
            nmx:"NMX-3980-292"
        },
        "ISO-92000":{
            nom:"NOM-8393-290",
            nmx:"NMX-2349-190"
        },
        "ISO-29199":{
            nom:"NOM-9390-000",
            nmx:"NMX-1298-170"
        },
        "ISO-12234":{
            nom:"NOM-2390-123",
            nmx:"NMX-2331-234"
        },
        "ISO-21220":{
            nom:"NOM-1245-332",
            nmx:"NMX-6145-293"
        },
        "ISO-89020":{
            nom:"NOM-1092-342",
            nmx:"NMX-6145-293"
        }
    };
    
    isoSelect.addEventListener("change",function(){
        const iso = this.value;
        nomSelect.value="";
        nmxSelect.value="";

        if(data[iso]){
            nomSelect.value=data[iso].nom;
            nmxSelect.value = data[iso].nmx;
        }
    });


});
        













      ///contrato-solicitud-requerimiento
     document.addEventListener("DOMContentLoaded",function(){
        const contratoSelect = document.querySelector('select[name="Input.Contrato"]');
        const solicitudSelect = document.querySelector('select[name="Input.Solicitud"]');
        const requerimientoSelect = document.querySelector('select[name="Input.Requerimiento"]');

        const data ={
            "CNE-8905-2345":{
                solicitud:"Solicitud 156CNE",
                requerimiento:"Requerimiento 1"
            },
            "CNE-2839-2929":{
                solicitud:"Solicitud 287CNE",
                requerimiento:"Requerimiento 2"
            },
            "CNE-2929-2929":{
                solicitud:"Solicitud 395CNE",
                requerimiento:"Requerimiento 3"
            },
            "CNE-2929-2202":{
                solicitud:"Solicitud 389CNE",
                requerimiento:"Requerimiento 4"
            },
            "CNE-2812-1234":{
                solicitud:"Solicitud 345CNE",
                requerimiento:"Requerimiento 5"
            }
        };
        contratoSelect.addEventListener("change",function(){
            const contrato = this.value;
            solicitudSelect.value="";
            requerimientoSelect.value="";


            if(data[contrato]){
                solicitudSelect.value = data[contrato].solicitud;
                requerimientoSelect.value = data[contrato].requerimiento;

            }

        });
     });
      ///script permiso-peticion
      document.addEventListener("DOMContentLoaded",function(){
        const permisoSelect = document.querySelector('select[name="Input.Permiso"]');
        const peticionSelect = document.querySelector('select[name="Input.Peticion"]');
        data = {
            "CNE-P1234-333":"Peticion 299737",
            "CNE-12344-999":"Peticion 334578",
            "CNE-23399-666":"Peticion 383763",
            "CNE-36779-927":"Peticion 837633",
            "CNE-92776-983":"Peticion 235753"
        };
        permisoSelect.addEventListener("change",function(){
            const permiso = this.value;
            peticionSelect.value="";
            if(data[permiso]){
                peticionSelect.value=data[permiso]
            }
        });
      });





        //seccion-regulacion-ley-organismo-encargado
        document.addEventListener("DOMContentLoaded",function(){
        const seccionSelect = document.querySelector('select[name="Input.Seccion"]');
        const regulacionSelect = document.querySelector('select[name="Input.Regulacion"]');
        const leySelect = document.querySelector('select[name="Input.Ley"]');
        const articuloSelect = document.querySelector('select[name="Input.Articulo"]');
        const ParrafoSelect = document.querySelector('select[name="Input.Parrafo"]');
        const legislacionSelect = document.querySelector('select[name="Input.Legislacion"]');

        const data = {
            "Electricidad": {
               regulacion:"Regulacion electrica",
               ley:"Ley energia 25-ENG-05",
               articulo:"Articulo XV",
               parrafo:"Parrafo 14",
               legislacion:"Legislacion XI"
            },
            "Gas": {
                regulacion:"Regulacion de gas",
                ley:"Ley gas 25-GS-06",
                articulo:"Articulo XX",
                parrafo:"Parrafo 5",
                legislacion:"Legislacion XX"
            },
            "Petroliferos": {
                regulacion:"Regulacion de petroleo",
                ley:"Ley petroleo 25-PTRL-05",
                articulo:"Articulo XVII",
                parrafo:"Parrafo 3",
                legislacion:"Legislacion IX"
            },
            "Hidrocarburos": {
                regulacion:"Regulacion de hidrocarburos",
                ley:"Ley hidrocarburos 25-HIC-03",
                articulo:"Articulo IX",
                parrafo:"Parrafo 8",
                legislacion:"Legislacion XIV"
            },
            "Quimica": {
                regulacion:"Regulacion quimica",
                ley:"Ley quimica 25-QM-02",
                articulo:"Articulo X",
                parrafo:"Parrafo 7",
                legislacion:"Legislacion XVI"
            }
        };

        seccionSelect.addEventListener("change",function(){
            const seccion = this.value;

            regulacionSelect.value="";
            leySelect.value="";
            articuloSelect.value="";
            ParrafoSelect.value="";
            legislacionSelect.value="";
     


            if(data[seccion]){
                regulacionSelect.value= data[seccion].regulacion;
                leySelect.value = data[seccion].ley;
                articuloSelect.value = data[seccion].articulo;
                ParrafoSelect.value = data[seccion].parrafo;
                legislacionSelect.value=data[seccion].legislacion;
            }
        });
      });


   ///seleccion de fecha pag(ZeroSecond)
 $gmx(document).ready(function () {
            $('#calendarYear').datepicker({ changeYear: true });
        });