﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_Produccion.Servicios
{
    [ServiceContract]
    public interface IParametroDetalles
    {
        [OperationContract]
        List<ParametroDetalle> ListarParametroDetalle(int idPadre);
    }
}
