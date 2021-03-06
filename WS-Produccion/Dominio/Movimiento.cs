﻿using System;
using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class Movimiento
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Nullable<System.DateTime> Fecha { get; set; }

        [DataMember]
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        [DataMember]
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        [DataMember]
        public string TipoMovimiento { get; set; }

        [DataMember]
        public Nullable<int> IdAlmacen { get; set; }

        [DataMember]
        public Nullable<int> IdOrdenTrabajo { get; set; }
    }
}