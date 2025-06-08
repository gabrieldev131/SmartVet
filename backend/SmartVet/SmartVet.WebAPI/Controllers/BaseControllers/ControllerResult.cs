using ConectaFapes.Common.Domain;
using ConectaFapes.Common.Domain.ResultEntities.Enum;
using ConectaFapes.Common.Utils.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartVet.WebApi.Controllers.BaseControllers
{
    public abstract class BaseControllerResult : Controller
    {
        /// <summary>
        /// Caso de sucesso: OkResult
        /// Caso de Erro: BadRequest
        /// </summary>
        /// <param name="result"></param>
        /// <returns>ObjectResult</returns>
        public virtual ObjectResult ApiOkResult<T>(TResult<T> result)
        {
            if (!result.IsSuccess)
            {
                return ApiBadRequestResult(result);
            }

            var apiResponse = result.Value is null ? new ApiResponse(200, "Requisicao realizada com sucesso!") :
                new ApiResponse(200, "Requisicao realizada com sucesso!", result.Value!);

            if (apiResponse != null)
            {
                var objectResult = new OkObjectResult(apiResponse);
                objectResult.StatusCode = apiResponse.StatusCode;
                return objectResult;
            }

            return Ok(apiResponse);
        }

        /// <summary>
        /// Caso de Sucesso: Retorna um CreateResult com URI.
        /// Caso de Erro: Retorna um BadRequest.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>ObjectResult</returns>
        public virtual ObjectResult ApiCreateResult<T>(TResult<T> result, Guid EntityId, HttpRequest request)
        {
            if (!result.IsSuccess || result.Value == null)
            {
                return ApiBadRequestResult(result);
            }

            var apiResponse = new ApiResponse(201, EntityId.ToString(), "Item criado com sucesso!");

            if (result != null)
            {
                adicionarURI(apiResponse.StatusCode);
                var objectResult = new OkObjectResult(apiResponse);
                objectResult.StatusCode = apiResponse.StatusCode;
                return objectResult;
            }

            void adicionarURI(int statusCode)
            {
                apiResponse.Uri = statusCode == 201 ? string.Concat(request.Path, "/", apiResponse.Uri) : request.Path;
            }

            return Ok(apiResponse);
        }

        /// <summary>
        /// Retorna um BadRequest
        /// </summary>
        /// <param name="result"></param>
        /// <returns>ObjectResult</returns>
        public virtual ObjectResult ApiBadRequestResult<T>(TResult<T> result)
        {
            int statusCode = result.Type.Equals(ResultType.BAD_REQUEST) ? 400 : 404;
            var apiResponse = new ApiResponse(statusCode, result.Type.ToString()!, result.Errors);
            var badRequest = new BadRequestObjectResult(apiResponse);
            badRequest.StatusCode = apiResponse.StatusCode;
            return badRequest;
        }
    }
}
