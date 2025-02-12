$root = "E:/Server/Template/"

cd $root
docker-compose up -d

$paths = @("/src/Template.Service/Template.Service.Service/bin/Debug/net9.0/", 
"src/Template.Files/Template.Files.Service/bin/Debug/net9.0/",
"src/Template.Gateway/Template.Gateway.Service/bin/Debug/net9.0/",
"src/Template.Job/Template.Job.Service/bin/Debug/net9.0/"
)
 
foreach ($element in $paths) {
    $path = Join-Path -Path $root -ChildPath $element
	cd $path
	docker-compose up -d
}

cd $root
docker-compose -f dapr.yml up -d
