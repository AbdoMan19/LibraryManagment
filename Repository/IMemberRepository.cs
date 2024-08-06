using LibraryManagment.Models;

namespace LibraryManagment.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAllMembers();
        Member GetMemberById(int id);
        bool AddMember(Member member);
        bool UpdateMember(Member member);
        bool DeleteMember(int id);
    }
}
