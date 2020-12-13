﻿using AutoMapper;
using NeatFleetManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeatFleetManager.Web
{
	public class PresentationMappingProfile : Profile
	{
		public PresentationMappingProfile()
		{
			this.CreateMap<CarServiceModel, CarViewModel>();
			this.CreateMap<CarViewModel, CarServiceModel>();
		}
	}
}