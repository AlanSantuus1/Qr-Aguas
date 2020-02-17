﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Models
{
    class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Cidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("erro")]
        public string Erro { get; set; }

    }
}
