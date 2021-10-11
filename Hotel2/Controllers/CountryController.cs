﻿using AutoMapper;
using Hotel2.IRepository;
using Hotel2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CountryController> _logger;
        private readonly IMapper _mapper;

        public CountryController(IUnitOfWork unitOfWork, ILogger<CountryController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper; 
        }

        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            try
            {
                var countries = await _unitOfWork.Countries.GetAll();
                var results =  _mapper.Map<IList<CountryDTO>>(countries);
                return Ok(results);

            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Something is amiss: {nameof(GetCountries)}");
                return StatusCode(500, "Internal Server Error. Please try back later.");
            }
        }
   }
}