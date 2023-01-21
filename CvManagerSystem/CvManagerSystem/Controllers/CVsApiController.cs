using Core.Dtos;
using Core.Entity.Dtos;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CvManagerSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVsApiController : ControllerBase
    {
        private readonly ICvRepository _repository;
        protected ResponseDto _response;
        public CVsApiController(ICvRepository repository)
        {
            _repository = repository;
            this._response = new ResponseDto();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<CvDto> cvs = await _repository.GetCvs();
                _response.Result = cvs;
            }
            catch (System.Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessasge = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPost]
        public async Task<object> Post([FromBody] CvDto cvDto)
        {
            try
            {
                CvDto model = await _repository.CreateUpdateCvs(cvDto);
                _response.Result = model;

            }
            catch (System.Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessasge = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPut]
        public async Task<object> put([FromBody] CvDto cvDto)
        {
            try
            {
                CvDto model = await _repository.CreateUpdateCvs(cvDto);
                _response.Result = model;

            }
            catch (System.Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessasge = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _repository.DeleteProduct(id);
                _response.Result = isSuccess;
            }
            catch (System.Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessasge = new List<string> { ex.ToString() };
            }
            return _response;



        }
    }
}
