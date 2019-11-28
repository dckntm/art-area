using System;
using System.Linq;
using System.Threading.Tasks;
using ArtArea.Web.Data.Interface;
using ArtArea.Web.Data.Mock;
using Xunit;

namespace ArtArea.Tests.Web.Data.Mock
{
    public class BoardRepositoryMockTests
    {
        private IBoardRepository repository = new BoardRepositoryMock();

        [Fact]
        public async Task Test_ReadBoards()
        {
            var boards = await repository.ReadBoards();

            Assert.Equal(boards, ApplicationDbMock.Boards);
        }

        [Fact]
        public async Task Test_ReadBoard_Success()
        {
            var boardId = ApplicationDbMock.Boards.FirstOrDefault().Id;
            var board = await repository.ReadBoard(boardId);

            Assert.Equal(board.Id, boardId);
        }

        [Fact]
        public async Task Test_ReadBoard_Fail()
        {
            var board = await repository.ReadBoard(Guid.NewGuid().ToString());

            Assert.Null(board);
        }
    }
}