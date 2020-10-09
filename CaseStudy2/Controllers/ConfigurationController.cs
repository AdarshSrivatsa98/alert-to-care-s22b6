﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaseStudy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {

        readonly Service.IIcuConfigurationService _icuConfigurationService;
        // OccupancyServiceImpl occupancyServiceImpl = new OccupancyServiceImpl();
        public ConfigurationController (Service.IIcuConfigurationService repo)
        {
            _icuConfigurationService = repo;
        }
        // GET: api/<ConfigurationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ConfigurationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConfigurationController>
        public String AddIcu([FromBody] Model.IcuSetUpData value)
        {
            _icuConfigurationService.AddNewIcu(value);
            return "New Icu Configuration Successfull";
        }


        // PUT api/<ConfigurationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConfigurationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}