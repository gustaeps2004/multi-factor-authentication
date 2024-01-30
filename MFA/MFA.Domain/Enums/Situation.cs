﻿using System.ComponentModel;

namespace MFA.Domain.Enums
{
    public enum Situation
    {
        [Description("Cadastrado")] 
        Cadastrado = 0,

        [Description("Ativado")] 
        Ativado = 1,

        [Description("Desativado")] 
        Desativado = 2
    }
}