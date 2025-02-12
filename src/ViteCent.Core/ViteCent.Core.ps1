$root = "E:\Server\Template\src\Template.Core"

$paths = @("/Template.Core/", 
"/Template.Core.Api/", 
"/Template.Core.Api.Swagger/",
"/Template.Core.Authorize/",
"/Template.Core.Authorize.Jwt/",
"/Template.Core.Cache/", 
"/Template.Core.Cache.Redis/",
"/Template.Core.Job/",
"/Template.Core.Job.Quartz/",
"/Template.Core.Logging/",
"/Template.Core.Logging.Log4Net/",
"/Template.Core.Orm/",
"/Template.Core.Orm.SqlSugar/",
"/Template.Core.Register/",
"/Template.Core.Register.Consul/",
"/Template.Core.Trace/",
"/Template.Core.Trace.Zipkin/",
"/Template.Core.Web/"
)
 
foreach ($element in $paths) {
    $path = Join-Path -Path $root -ChildPath $element
	cd $path
	dotnet pack
}