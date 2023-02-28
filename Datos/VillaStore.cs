using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
                            new VillaDto {Id=1, Nombre= "Vista a la Piscina", MetrosCuadrados= 50, Ocupantes=5},
                new VillaDto {Id=2,Nombre=" Vista a la Playa", MetrosCuadrados= 30, Ocupantes=2}
        };
    }
}
