﻿namespace Orchard.ImportExport.Services {
    public interface ISigningService : IDependency {
        string AuthenticationHeaderName { get; }
        string ContentHashHeaderName { get; }
        string TimestampFormat { get; }
        string TimestampHeaderName { get; }

        string SignRequest(string methodType, string timestamp, string uri, string secret);
        bool ValidateRequest(string methodType, string timestamp, string uri, string secret, string signature);

        string SignContent(string content, string timestamp, string secret);
        bool ValidateContent(string content, string timestamp, string secret, string signature);
    }
}
