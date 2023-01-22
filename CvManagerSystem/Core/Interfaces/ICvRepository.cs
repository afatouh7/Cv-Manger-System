using Core.Dtos;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICvRepository
    {

        Task<IEnumerable<CvDto>> GetCvs();
        Task<CvDto> CreateUpdateCvs(CvDto cvDto);
        Task<bool> DeleteProduct(int cvId);
        Task<CvDto> GetCvById(int id);
    }
}
