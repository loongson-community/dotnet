// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Hosting.Postgres;

internal static class PostgresContainerImageTags
{
    public const string Registry = "docker.io";
    public const string Image = "library/postgres";
    public const string Tag = "17.0";
    public const string PgAdminRegistry = "docker.io";
    public const string PgAdminImage = "dpage/pgadmin4";
    public const string PgAdminTag = "8.12";
    public const string PgWebRegistry = "docker.io";
    public const string PgWebImage = "sosedoff/pgweb";
    public const string PgWebTag = "0.16.1";
}
