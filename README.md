# repro_fls_reactor_3proj_issue

Steps
1. Open Library.fs and kick off fsharp-language-server.
2. Attach a debugger to the fls process.
3. Note that reactor is constantly executing `Unknown.ImplicitlyStartCheckProjectInBackground.CreateOneIncrementalBuilder`.

The issue doesn't repro if there are only 2 project references.
