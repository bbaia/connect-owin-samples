module.exports = function (grunt) {
    'use strict';

    // Load all grunt tasks
    require('load-grunt-tasks')(grunt);

    // Project configuration
    grunt.initConfig({

        // Task configuration
        watch: {
            livereload: {
                options: {
                    livereload: true
                },
                files: [
                    'Site/js/*.js',
                    'Site/*.html'
                ]
            }
        },
        connect: {
            options: {
                hostname: 'localhost',
                port: 9000,
            },
            livereload: {
                options: {
                    middleware: function (connect) {
                        return [
                            require('connect-livereload')(),
                            require('connect-owin')(__dirname + '\\bin\\debug\\Samples.WebApi.dll'),
                            connect.static(require('path').resolve('Site'))
                        ];
                    }
                }
            }
        },
        open: {
            server: {
                url: 'http://<%= connect.options.hostname %>:<%= connect.options.port %>/index.html'
            }
        }
    });

    // Tasks definition

    grunt.registerTask('server', [
        'connect:livereload',
        'open',
        'watch'
    ]);

    grunt.registerTask('default', ['server']);
};