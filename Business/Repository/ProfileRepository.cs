using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext _db;

        private readonly IMapper _mapper;

        public ProfileRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<ProfileDTO> CreateProfile(ProfileDTO profileDTO)
        {
            DataAccess.Data.Profile profile = _mapper.Map<ProfileDTO, DataAccess.Data.Profile>(profileDTO);
            profile.CreatedDate = DateTime.Now;
            var addedProfile = await _db.Profiles.AddAsync(profile);
            await _db.SaveChangesAsync();
            return _mapper.Map<DataAccess.Data.Profile, ProfileDTO>(addedProfile.Entity);
        }
    }
}
