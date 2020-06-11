using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Model
{
    public class IdeaRepository : IIdeaRepository  // 인터페이스 레포지토리를 상속받는 서비스 클래스
    {
        private readonly ApplicationDbContext _context;

        public IdeaRepository(ApplicationDbContext context)  // 필드 구현체
        {
            this._context = context;
        }
        public async Task<Idea> AddIdea(Idea idea)
        {
            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();
            return idea;
        }

        public async Task<List<Idea>> GetIdeas()
        {
            return await _context.Ideas.ToListAsync();
        }
    }
}
