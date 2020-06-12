using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public interface IIdeaRepository
    {
        Task<Idea> AddIdea(Idea idea); // 입력 메서드
        Task<List<Idea>> GetIdeas();  // 출력 메서드
    }
}
