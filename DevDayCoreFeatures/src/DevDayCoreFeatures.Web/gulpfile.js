var gulp = require('gulp');

var gulpSass = require('gulp-sass');

gulp.task('compile-sass', function () {
    gulp.src('./wwwroot/lib/bootstrap/scss/bootstrap.scss')
        .pipe(gulpSass())
        .pipe(gulp.dest('./wwwroot/css'));
});


