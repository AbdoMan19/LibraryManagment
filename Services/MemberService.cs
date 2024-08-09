using LibraryManagment.Models;
using LibraryManagment.UnitOfWork;

namespace LibraryManagment.Services
{
    public class MemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MemberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            return await _unitOfWork.MemberRepository.GetAll();
            
        }

        public async Task<Member?> GetMemberById(int id)
        {
            return await _unitOfWork.MemberRepository.GetById(id);
        }

        public async Task<bool> AddMember(Member member)
        {
             await _unitOfWork.MemberRepository.Add(member);
             return await _unitOfWork.SaveAsync(); ;
        }

        public async Task<bool> UpdateMember(Member member)
        {
            _unitOfWork.MemberRepository.Update(member);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteMemberAsync(Member member)
        {
            _unitOfWork.MemberRepository.Delete(member);
            return await _unitOfWork.SaveAsync();
        }
    }
}
