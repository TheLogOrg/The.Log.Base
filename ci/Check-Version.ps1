Param(
    [string]$ProjectFilePath,
    [string]$TagName
)

$versionElement = Select-Xml -Path $projectFilePath -XPath "/Project/PropertyGroup/Version"

$version = $versionElement.Node.InnerXml

if ($version.Equals($tagName)) {
    Write-Host "Version from project matches tag name!"

    exit 0
} else {
    Write-Error "Version mismatch"
    Write-Host "Expected: $tagName"
    Write-Host "Actual: $projectVersion"
    exit 1
}