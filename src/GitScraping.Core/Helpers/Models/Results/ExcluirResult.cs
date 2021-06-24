﻿#region

using GitScraping.Core.Helpers.Messages;
using GitScraping.Domain.Bases;
using GitScraping.Domain.Enums;

#endregion

namespace GitScraping.Core.Helpers.Models.Results
{
    public class ExcluirResult<TEntity> : SingleResult<TEntity>
        where TEntity : Entity
    {
        public ExcluirResult()
        {
            Codigo = (int) EnumResultadoAcao.Sucesso;
            Sucesso = true;
            Mensagem = MensagensNegocio.ResourceManager.GetString("MSG03");
        }

        public ExcluirResult(bool sucesso, string mensagem)
        {
            Codigo = sucesso ? (int) EnumResultadoAcao.Sucesso : (int) EnumResultadoAcao.ErroNaoEncontrado;
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public ExcluirResult(string mensagem)
        {
            Codigo = (int) EnumResultadoAcao.ErroNaoEncontrado;
            Sucesso = false;
            Mensagem = mensagem;
        }
    }
}