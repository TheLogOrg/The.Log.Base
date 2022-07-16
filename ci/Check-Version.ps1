Param(
    [string]$ProjectFilePath,
    [string]$TagName
)

$versionElement = Select-Xml -Path $projectFilePath -XPath "/Project/PropertyGroup/Version"

$version = $versionElement.Node.InnerXml

if ($version.Equals($tagName)) {
    Write-Host "[SUCC] " -ForegroundColor Green -NoNewline
    Write-Host "Version from project matches tag name!"

    exit 0
} else {
    Write-Host "[FAIL] " -ForegroundColor Red -NoNewline
    Write-Host "Version mismatch"
    Write-Host "Expected: $tagName"
    Write-Host "Actual: $projectVersion"

    exit 1
}