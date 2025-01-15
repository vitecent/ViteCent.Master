$root = "E:/Server/YPHF.FSS/"

cd $root
docker-compose up -d

$paths = @("/src/YPHF.Servic/YPHF.Service.Service/bin/Debug/net9.0/", 
"src/YPHF.Files/YPHF.Files.Service/bin/Debug/net9.0/",
"src/YPHF.Gateway/YPHF.Gateway.Service/bin/Debug/net9.0/",
"src/YPHF.Job/YPHF.Job.Service/bin/Debug/net9.0/"
)
 
foreach ($element in $paths) {
    $path = Join-Path -Path $root -ChildPath $element
	cd $path
	docker-compose up -d
}

cd $root
docker-compose -f dapr.yml up -d
