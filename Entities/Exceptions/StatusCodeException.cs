namespace Entities.Exceptions
{
    public class StatusCodeException : Exception
    {
        private string errorObj;

        public StatusCodeException(long code, object obj)
        {
            switch (obj)
            {
                case Account: errorObj = "Account"; break;
                case MMR: errorObj = "MMR"; break;
            }

            switch (code)
            {
                case 200: break;
                case 400: throw new StatusCodeException($"{errorObj} Error 400: Request error by the client");                 
                case 403: throw new StatusCodeException($"{errorObj} Error 403: Forbidden to connect to the Riot API");
                case 404: throw new StatusCodeException($"{errorObj} Error 404: The entity was not found (player / match / general data)");
                case 408: throw new StatusCodeException($"{errorObj} Error 408: Timeout while fetching riot data");
                case 410: throw new StatusCodeException($"{errorObj} Error 410: Endpoint is deprecated");
                case 429: throw new StatusCodeException($"{errorObj} Error 429: Rate limit reached");
                case 501: throw new StatusCodeException($"{errorObj} Error 501: API Version not implemented, check the requested endpoint url");
                case 503: throw new StatusCodeException($"{errorObj} Error 503: Riot API seems to be down, API unable to connect");
                default: throw new StatusCodeException("Unknown error");
            }
        }

        private StatusCodeException(string message) : base(message) { }
    }
}
