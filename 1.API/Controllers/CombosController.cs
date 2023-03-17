using _1.API.ViewModels.Combo;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CombosController : ControllerBase
        {
            private IAllRepositories<Combo> _repo;


            public CombosController(IAllRepositories<Combo> repo)
            {
                _repo = repo;

            }

            [HttpGet]
            [Route("Get-All")]
            public async Task<IActionResult> GetAllCombo()
            {
                var result = await _repo.GetAllAsync();
                if (result == null) return Ok("Không có chức vụ");
                return Ok(result);
            }

            [HttpGet]
            [Route("GetById/{id}")]
            public async Task<IActionResult> GetComboById(Guid id)
            {
                var result = await _repo.GetByIdAsync(id);
                if (result == null) return Ok("Không tìm thấy combo");
                return Ok(result);
            }

            [HttpPost]
            [Route("Create")]
            public async Task<IActionResult> CreateCombo([FromBody] CreateCombo ccv)
            {
                Combo cv = new Combo()
                {
                    Id = Guid.NewGuid(),
                    Ten = ccv.Ten,
                    SoLuong = ccv.SoLuong,
                    GiaBan = ccv.GiaBan,
                    IdMonAn = ccv.IdMonAn,
                    IdDoUong = ccv.IdDoUong,
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
            public async Task<IActionResult> UpdateCombo(Guid id, [FromBody] UpdateCombo ucv)
            {
                var result = await _repo.GetByIdAsync(id);
                if (result == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy combo");
                }
                else
                {
                    result.Ten = ucv.Ten;
                    result.IdMonAn = ucv.IdMonAn;
                    result.IdDoUong = ucv.IdDoUong;
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
                    return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy combo");
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
