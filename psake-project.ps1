Framework "4.6"

Properties {
    $solution = "SystemWrapper.sln"
}

Include "Build\psake-common.ps1"

Task Default -Depends Clean, Build, RunTests
