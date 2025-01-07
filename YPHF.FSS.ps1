$Path = "E:/Server/YPHF.FSS/"

cd $Path
docker-compose up -d

$PathAirspace = Join-Path -Path $Path -ChildPath "/src/YPHF.Airspace/YPHF.Airspace.Service/bin/Debug/net9.0/"
cd $PathAirspace
docker-compose up -d

$PathAuth = Join-Path -Path $Path -ChildPath "src/YPHF.Auth/YPHF.Auth.Service/bin/Debug/net9.0/"
cd $PathAuth
docker-compose up -d

$PathBasic = Join-Path -Path $Path -ChildPath "src/YPHF.Basic/YPHF.Basic.Service/bin/Debug/net9.0/"
cd $PathBasic
docker-compose up -d

$PathEvents = Join-Path -Path $Path -ChildPath "src/YPHF.Events/YPHF.Events.Service/bin/Debug/net9.0/"
cd $PathEvents
docker-compose up -d

$PathFiles = Join-Path -Path $Path -ChildPath "src/YPHF.Files/YPHF.Files.Service/bin/Debug/net9.0/"
cd $PathFiles
docker-compose up -d

$PathGateway = Join-Path -Path $Path -ChildPath "src/YPHF.Gateway/YPHF.Gateway.Service/bin/Debug/net9.0/"
cd $PathGateway
docker-compose up -d

$PathGen = Join-Path -Path $Path -ChildPath "src/YPHF.Gen/YPHF.Gen.Service/bin/Debug/net9.0/"
cd $PathGen
docker-compose up -d

$PathGov = Join-Path -Path $Path -ChildPath "src/YPHF.Gov/YPHF.Gov.Service/bin/Debug/net9.0/"
cd $PathGov
docker-compose up -d

$PathJob = Join-Path -Path $Path -ChildPath "src/YPHF.Job/YPHF.Job.Service/bin/Debug/net9.0/"
cd $PathJob
docker-compose up -d

$PathPlan = Join-Path -Path $Path -ChildPath "src/YPHF.Plan/YPHF.Plan.Service/bin/Debug/net9.0/"
cd $PathPlan
docker-compose up -d

$PathPush = Join-Path -Path $Path -ChildPath "src/YPHF.Push/YPHF.Push.Service/bin/Debug/net9.0/"
cd $PathPush
docker-compose up -d

$PathSignal = Join-Path -Path $Path -ChildPath "src/YPHF.Signal/YPHF.Signal.Service/bin/Debug/net9.0/"
cd $PathSignal
docker-compose up -d

$PathStatistics = Join-Path -Path $Path -ChildPath "src/YPHF.Statistics/YPHF.Statistics.Service/bin/Debug/net9.0/"
cd $PathStatistics
docker-compose up -d

$PathWeather = Join-Path -Path $Path -ChildPath "src/YPHF.Weather/YPHF.Weather.Service/bin/Debug/net9.0/"
cd $PathWeather
docker-compose up -d

cd $Path
docker-compose -f dapr.yml up -d
