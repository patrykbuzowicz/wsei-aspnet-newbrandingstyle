/// <binding AfterBuild='scss' />
const gulp = require("gulp");
const sass = require("gulp-sass");

const paths = {
    scss: "./Styles/**/*.scss",
    css: "./wwwroot/css/"
};

gulp.task("scss", () => {
    return gulp.src(paths.scss)
        .pipe(sass())
        .pipe(gulp.dest(paths.css));
});
