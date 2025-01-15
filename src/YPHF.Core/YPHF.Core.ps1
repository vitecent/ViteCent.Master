$root = "E:\Server\YPHF.FSS\src\YPHF.Core"

$paths = @("/YPHF.Core/", 
"/YPHF.Core.Api/", 
"/YPHF.Core.Api.Swagger/",
"/YPHF.Core.Cache/", 
"/YPHF.Core.Cache.Redis/",
"/YPHF.Core.Job/",
"/YPHF.Core.Job.Quartz/",
"/YPHF.Core.Logging/",
"/YPHF.Core.Logging.Log4Net/",
"/YPHF.Core.Orm/",
"/YPHF.Core.Orm.SqlSugar/",
"/YPHF.Core.Register/",
"/YPHF.Core.Register.Consul/",
"/YPHF.Core.Trace/",
"/YPHF.Core.Trace.Zipkin/",
"/YPHF.Core.Web/"
)
 
foreach ($element in $paths) {
    $path = Join-Path -Path $root -ChildPath $element
	cd $path
	dotnet pack
}