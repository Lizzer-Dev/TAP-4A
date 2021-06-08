using SQLApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SQLApp.Services;
namespace SQLApp.Controllers
{
    public class EstadoController
    {
        Estado estado;
        List<Estado> list;
        public List<Estado> listar(){
            list = EstadoService.GetAll();
            return list;
        }
        public void guardar(Estado e)
        {
            try
            {
                if (validate(e))
                {
                    var estado = list.Find(item => item.Id == e.Id);
                    if (estado == null)
                        EstadoService.Insert(e);
                    else
                        throw new Exception("El ID ya fue utilizado en otro registro");
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void actualizar(Estado e)
        {
            var estado = list.Find(item => item.Id == e.Id);
            if (estado != null)
            {
                estado.Name = e.Name;
                estado.Surface = e.Surface;
            }
            else
            {

            }
            try
            {
                if (validate(estado)) _ = EstadoService.Update(estado);
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        private bool validate(Estado e)
        {
            if (e.Id <= 0)
                throw new Exception("ID id Mandatory");
            if (e.Name.Length == 0)
                throw new Exception("Name is Mandatory");
            if (e.Surface < 0)
                throw new Exception("Surface is Mandatory");
            return true;
        }
    }
}
