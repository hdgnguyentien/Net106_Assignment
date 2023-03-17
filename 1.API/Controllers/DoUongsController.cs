using _1.API.ViewModels.Combo;
using _1.API.ViewModels.DoUong;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoUongsController : ControllerBase
    {
        private IAllRepositories<DoUong> _repo;


        public DoUongsController(IAllRepositories<DoUong> repo)
        {
            _repo = repo;

        }

        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllDoUong()
        {
            var result = await _repo.GetAllAsync();
            if (result == null) return Ok("Không có chức vụ");
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetDoUongById(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null) return Ok("Không tìm thấy đồ uống");
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateDoUong([FromBody] CreateDoUong ccv)
        {
            DoUong cv = new DoUong()
            {
                Id = Guid.NewGuid(),
                Ten = ccv.Ten,
                SoLuong = ccv.SoLuong,
                GiaBan = ccv.GiaBan,
                GiaNhap = ccv.GiaNhap,
                TrangThai = ccv.TrangThai,
            };
            try
            {
                var result = await _repo.AddOneAsyn(cv);
                return Ok(cv);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Tạo mới không thành công");
            }

        }

        [HttpPost]
        [Route("Update/id")]
        public async Task<IActionResult> UpdateDoUong(Guid id, [FromBody] UpdateDoUong ucv)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy đồ uống");
            }
            else
            {
                result.Ten = ucv.Ten;
                result.GiaNhap = ucv.GiaNhap;
                result.TrangThai = ucv.TrangThai;
                result.SoLuong = ucv.SoLuong;
                result.GiaBan = ucv.GiaBan;
                try
                {
                    await _repo.UpdateOneAsyn(result);
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Update không thành công");
                }


            }

        }
        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy đồ uống");
            }
            else
            {
                try
                {
                    await _repo.DeleteOneAsyn(result);
                    return Ok("Xóa thành công");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Xóa không thành công");
                }


            }
        }
    }
}
