using Excursionistas.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz_WEB
{
    public partial class Presentacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ExcursionistasEntities _Entidad = new ExcursionistasEntities();
        protected void BtnVerificar_Click(object sender, EventArgs e)
        {
            

            IEnumerable<Elementos> ListaElementos = _Entidad.Elementos.ToList().OrderBy(x => x.Peso);
            TbRespuesta.Text = ElementosIdeales(ListaElementos);
        }

        // Metodo que devuelve una lista string
        private string ElementosIdeales(IEnumerable<Elementos> Elementos)
        {
            int Peso = 0;
            int Calorias = 0;
            var Respuesta = "Elementos ideales: ";

            foreach (var item in Elementos)
            {
                int PesoActual = Convert.ToInt32(item.Peso);
                int CaloriaActual = Convert.ToInt32(item.Calorias);


                // Acumula cada uno elementos Recorridos en las variables PESO y las CALORIAS.
                Peso += Convert.ToInt32(item.Peso);
                Calorias += Convert.ToInt32(item.Calorias);


                // Si el Peso que se ingresa en el Texbox es menor o igual al Acomulado del peso se incrementa la variable respuesta con el elemento 
                if (Convert.ToInt32(TbPeso.Text) >= Peso)
                {
                    Respuesta += item.Elemento + " ";
                }
                else
                {
                    // Si por algun motivo cumple con el peso ingresado maximo y no cumple con cumple con las calorias,
                    // se va a restar el peso al acomulado para que en la siguiente vuelta le de la oportunidad al siguiente peso y calorias
                    if (Convert.ToInt32(TbCalorias.Text) >= Calorias)
                    {
                        Peso = Peso - PesoActual;
                        Calorias = Calorias - CaloriaActual;
                    }
                }
            }
            return Respuesta;
        }
    }
}