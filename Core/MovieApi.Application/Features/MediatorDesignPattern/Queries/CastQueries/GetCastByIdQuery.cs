﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResult;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }

        public int CastId { get; set; }
    }
}
