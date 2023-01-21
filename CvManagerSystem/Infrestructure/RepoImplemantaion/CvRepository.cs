
using AutoMapper;
using Core.Dtos;
using Core.Entity;
using Core.Interfaces;
using Infrestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrestructure.RepoImplemantaion
{
    public class CvRepository : ICvRepository
    {
        private readonly CvContext _context;
        private readonly IMapper _mapper;
        public CvRepository(CvContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CvDto> CreateUpdateCvs(CvDto cvDto)
        {
            CV cv = _mapper.Map<CvDto, CV>(cvDto);
            if(cv.Id > 0)
            {
                _context.CVs.Update(cv);
            }
            else
            {
              
                _context.CVs.Add(cv);
            }
            await _context.SaveChangesAsync();
            return _mapper.Map<CV, CvDto>(cv);
        }

        public async Task<bool> DeleteProduct(int cvId)
        {
            try
            {
                CV cv = await _context.CVs.FirstOrDefaultAsync(d => d.Id == cvId);
                if (cv == null)
                {
                    return false;
                }
                
                _context.CVs.Remove(cv);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<CvDto>> GetCvs()
        {
            List<CV> cv = await _context.CVs.Include(x=>x.PersonalInformation).Include(x=>x.ExperienceInformation).ToListAsync();
            return _mapper.Map<List<CvDto>>(cv);
        }
    }
}
