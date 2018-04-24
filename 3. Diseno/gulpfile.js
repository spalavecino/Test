'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');
var sourcemaps = require('gulp-sourcemaps');
var cleanCSS = require('gulp-clean-css');
var autoprefixer = require('gulp-autoprefixer');

gulp.task('sass', function () {
	return gulp.src('./sass/*.scss')
		.pipe(sourcemaps.init())
		.pipe(sass().on('error', sass.logError))
		.pipe(sourcemaps.write())
		.pipe(gulp.dest('./css'));
});

gulp.task('sass_prod', function () {
	return gulp.src('./sass/*.scss')
		.pipe(sass().on('error', sass.logError))
		.pipe(autoprefixer({ browsers: ['last 2 version', 'last 5 safari versions', 'ie 8-11', 'Firefox > 40', 'Chrome > 40', 'opera > 25', 'last 5 iOS versions', 'android 4', 'android > 5'] }))
		.pipe(cleanCSS({ compatibility: 'ie11' }))
		.pipe(gulp.dest('./css'));
});

gulp.task('default', ['sass']);
//gulp.task('default', ['sass_prod']);