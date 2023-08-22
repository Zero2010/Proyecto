using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.ViewModel
{
    public class CargaMaestraViewModel
    {
        public string Sku                       { get; set; }
        public string Ean                       { get; set; }
        public string Descripcion               { get; set; }
    }

    public class MaestraViewModel
    {
        public string NUMCONTEO                 { get; set; }
        public string FECHA                     { get; set; }
        public string CODIGO_INTERNO            { get; set; }
        public string LOCALES                   { get; set; }
        public string TIPO_INVENTARIO           { get; set; }
        public string DESCRIPCION               { get; set; }
        public string MARCA                     { get; set; }
        public string UNIDAD_MEDIDA             { get; set; }
        public string PRECIO                    { get; set; }
        public string MONEDA                    { get; set; }
        public string SUB_CLASE                 { get; set; }
        public string DESCRIPCION_SUBCLASE      { get; set; }
        public string CLASE                     { get; set; }
        public string DESCRIPCION_CLASE         { get; set; }
        public string SUB_DEPARTAMENTO          { get; set; }
        public string DESCRIPCION_SUB_DPTO      { get; set; }
        public string DEPARTAMENTO              { get; set; }
        public string DESCRIPCION_DPTO          { get; set; }
        public string FECHA_CREACION_ARCHIVO    { get; set; }
        public string TIPO_CODBARRA             { get; set; }
        public string EAN                       { get; set; }
        public string CANTIDAD                  { get; set; }
    }


    public class MaestraErrorViewModel
    {
        public string NUMCONTEO                 { get; set; }
        public string FECHA                     { get; set; }
        public string CODIGO_INTERNO            { get; set; }
        public string LOCALES                   { get; set; }
        public string TIPO_INVENTARIO           { get; set; }
        public string DESCRIPCION               { get; set; }
        public string MARCA                     { get; set; }
        public string UNIDAD_MEDIDA             { get; set; }
        public string PRECIO                    { get; set; }
        public string MONEDA                    { get; set; }
        public string SUB_CLASE                 { get; set; }
        public string DESCRIPCION_SUBCLASE      { get; set; }
        public string CLASE                     { get; set; }
        public string DESCRIPCION_CLASE         { get; set; }
        public string SUB_DEPARTAMENTO          { get; set; }
        public string DESCRIPCION_SUB_DPTO      { get; set; }
        public string DEPARTAMENTO              { get; set; }
        public string DESCRIPCION_DPTO          { get; set; }
        public string FECHA_CREACION_ARCHIVO    { get; set; }
        public string TIPO_CODBARRA             { get; set; }
        public string EAN                       { get; set; }
        public string CANTIDAD                  { get; set; }
    }
}