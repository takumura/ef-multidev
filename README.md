# ef-multidev

Check how to use entity framework in team development

# Development Step

## Create 2 branches

- add-date-to-account
- introduce-sign

## Complete Development for add-date-to-account

create pull request, and merge to master except for migraiton files.

## Merge database change to master

Create merge-database branch and merge database to master.

## Complete Development for introduce-sign

On `git merge master`, auto-merge failed for csproj file, need to merge manually. After that, build succeeded but runtime error raised because of database structure mismatch.

```
Update-Database
Add-Migration blank
```

After creating blank migration, delete any process on Up() and Down() method. Then run `Update-Database` again. Finally the runtime error resolved.

create pull request, and merge to master except for migraiton files

## Merge database change to master

Create merge-database branch and merge database to master
