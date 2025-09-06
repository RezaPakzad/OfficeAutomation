# مسیر پروژه
$projectPath = "D:\OfficeAutomation"

# پیدا کردن همه پوشه‌های .git داخل پروژه (غیر از ریشه)
$gitDirs = Get-ChildItem -Path $projectPath -Recurse -Force -Directory -Filter ".git"

foreach ($dir in $gitDirs) {
    Write-Host "Deleting: $($dir.FullName)" -ForegroundColor Yellow
    Remove-Item -Recurse -Force $dir.FullName
}

Write-Host "✅ All nested .git folders removed successfully!" -ForegroundColor Green
