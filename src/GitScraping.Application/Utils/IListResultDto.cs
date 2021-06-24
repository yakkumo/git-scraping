﻿#region

using System.Collections.Generic;
using GitScraping.Application.Bases;

#endregion

namespace GitScraping.Application.Utils
{
    public interface IListResultDto<TDto> : IResultDto
        where TDto : Dto
    {
        IList<TDto> Data { get; set; }
    }
}